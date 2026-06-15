// Innovace Intech Solution Pvt Ltd
import { usePageStore } from "../../store/usePageStore";
import { uploadDocument, ExtractDocumentOcr, deleteDocument } from "../../services/documentService";
import toast from "react-hot-toast";
import { useUserStore } from "../../store/useUserStore";

export async function resusableOnFileChange(
  files: FileList | null,
  {
    maxSize,
    ElementName,
    isGrid,
  }: { maxSize: number; ElementName: string; isGrid: boolean }
) {
  if (!files || !files.length) return;

  try {
    let data = null;

    const activePage = usePageStore.getState().activePage;
    const slotId =
      useUserStore.getState().slotId ||
      sessionStorage.getItem("accessToken");

    const controlId = isGrid ? ElementName.split("+")[2] : ElementName;

    let tempFileRaw = files[0];

    // ✅ STEP 1: FIX FILE NAME (camera gives blob/no name)
    let fileName = tempFileRaw.name;
    if (!fileName || fileName === "blob" || fileName === "image") {
      const ext = tempFileRaw.type.split("/")[1] || "jpg";
      fileName = `capture_${Date.now()}.${ext}`;
    }

    // ✅ STEP 2: FIX HEIC (iPhone issue)
    let fileType = tempFileRaw.type;
    if (fileType.includes("heic")) {
      fileType = "image/jpeg";
    }

    let tempFile = new File([tempFileRaw], fileName, {
      type: fileType,
    });

    // ✅ STEP 3: COMPRESS IMAGE (IMPORTANT FOR CAMERA)
    if (fileType.startsWith("image/")) {
      tempFile = await compressImage(tempFile);
    }

    // ✅ STEP 4: SIZE CHECK AFTER COMPRESSION
    if (tempFile.size > maxSize) {
      toast.error("File size exceeds the limit");
      return;
    }

    console.log("FINAL FILE:", {
      name: tempFile.name,
      type: tempFile.type,
      size: (tempFile.size / 1024 / 1024).toFixed(2) + " MB",
    });

    // ✅ STEP 5: FORM DATA
    const formData = new FormData();
    formData.append("SlotId", slotId || "");
    formData.append("DcmtId", "-1");
    formData.append("FormVersionId", activePage?.["FormVersionId"] || "");
    formData.append("Comments", "");
    formData.append("DocName", tempFile.name);
    formData.append("ControlId", controlId);
    formData.append("File", tempFile);

    // ✅ STEP 6: API CALL
    if (controlId === "MF_d2_DocId") {
      data = await ExtractDocumentOcr(formData);
    } else {
      data = await uploadDocument(formData);
    }

    // ✅ STEP 7: API VALIDATION
    const isInvalid = data?.find((item: any) => item.key === -2);
    if (isInvalid) {
      toast.error(isInvalid.value);
      return;
    }

    toast.success("File uploaded successfully");

    sessionStorage.setItem("MF_d2_DocId", data?.[3]?.value);

    return {
      base64Data: data?.[1]?.value,
      documentId: data?.[2]?.key,
      documentNo: data?.[2]?.value,
      fileName: tempFile.name,
      fileType: tempFile.name.split(".").pop()?.toLowerCase() || "",
    };
  } catch (error: any) {
    console.error("UPLOAD ERROR:", error);

    if (error?.response) {
      console.error("API ERROR:", error.response.data);
    }

    toast.error(error?.data[0]?.value || "File upload failed");
  }
}

export const resusableDeleteDocument = async ({
  isGrid,
  documentId,
  documentNo,
  elementName,
}: {
  isGrid: boolean;
  documentId: string;
  documentNo: string;
  elementName: string;
}) => {
  const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
  const controlId = isGrid ? elementName.split("+")[2] : elementName;

  const data = await deleteDocument({
    slotId: slotId || "",
    documentId: documentId,
    documentNo: documentNo,
    documentTypeId: controlId,
  });

  const response = Number(data);


  if (response === 1) {
    toast.error("File delete failed");
    return false;
  } else {
    toast.success("File deleted successfully");
    return true;
  }
};


const compressImage = async (file: File): Promise<File> => {
  const img = await createImageBitmap(file);

  const canvas = document.createElement("canvas");
  const ctx = canvas.getContext("2d");

  const MAX_WIDTH = 1280;

  const scale = Math.min(1, MAX_WIDTH / img.width);

  canvas.width = img.width * scale;
  canvas.height = img.height * scale;

  ctx?.drawImage(img, 0, 0, canvas.width, canvas.height);

  return new Promise((resolve) => {
    canvas.toBlob(
      (blob) => {
        resolve(
          new File([blob!], file.name.replace(/\.\w+$/, ".jpg"), {
            type: "image/jpeg",
          })
        );
      },
      "image/jpeg",
      0.7
    );
  });
};