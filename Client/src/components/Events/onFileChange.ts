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

  const tempFile = files[0];

  if (tempFile.size > maxSize) {
    toast.error("File size exceeds the limit");
    return;
  }

  try {
    let data = null;
    const activePage = usePageStore.getState().activePage;
    const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");

    const controlId = isGrid ? ElementName.split("+")[2] : ElementName;

    const formData = new FormData();
    formData.append("SlotId", slotId || "");
    formData.append("DcmtId", "-1");
    formData.append("FormVersionId", activePage?.["FormVersionId"] || "");
    formData.append("Comments", "");
    formData.append("DocName", tempFile.name);
    formData.append("ControlId", controlId);
    formData.append("File", tempFile);

    if(controlId == "MF_d2_DocId"){
       data = await ExtractDocumentOcr(formData);
    }else{
       data = await uploadDocument(formData);
    }

    // const data = await uploadDocument(formData);

    const isInvalid = data.find((item: any) => item.key === -2);

    if (isInvalid) {
      toast.error(isInvalid.value);
      return;
    }

    toast.success("File uploaded successfully");
    sessionStorage.setItem("MF_d2_DocId",data[3]?.value)
    return {
      base64Data: data[1].value,
      documentId: data[2].key,
      documentNo: data[2].value,
      fileName: tempFile.name,
      fileType: tempFile.name.split(".").at(-1)?.toLowerCase() || "",
    };
  } catch (error) {
    console.log(error);
    toast.error("File upload failed");
    return;
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

  if (data === 1) {
    toast.error("File delete failed");
    return false;
  } else {
    toast.success("File deleted successfully");
    return true;
  }
};
