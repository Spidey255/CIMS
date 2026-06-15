// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useRef, useState } from "react";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { getExtensionFromBase64, downloadFile } from "@/helpers/utils";
import { getBase64StringFromUrl } from "@/services/documentService";

const DownloadOnly: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );
   
  const slotId = useUserStore((store) => store.slotId);
  const [base64Data, setBase64Data] = useState<string>();

  const fileInputRef = useRef<HTMLInputElement>(null);

  const fileName = state?.toString().includes("#")
    ? state?.toString().split("#")[1]
    : state?.toString();

  const handleLoadData = useCallback(async () => {
    if (!state || !state?.toString().includes("#")) return;

       try {
      const data = await getBase64StringFromUrl(
        slotId || "",
        state.toString().split("#")[0],
        1
      );

      if (data.length) {
        const extension = getExtensionFromBase64(data[0].value.split(",")[0]);
        if (extension) {
          setBase64Data(data[0].value);
        }

        // setDocumentData({ documentId: data[1].key, documentNo: data[1].value });
      }
    } catch (error) {
      console.log(error);
    }
  }, [state, slotId]);

  useEffect(() => {
    handleLoadData();
  }, [handleLoadData]);

  const handleDownloadFile = () => {
    if (base64Data) downloadFile(fileName, base64Data);
  };

  return (
    <>
      <div
        className={element.ColumnCss}
        id={element.ElementName}
        onClick={(e) => e.stopPropagation()}
      >
        <div className="form-group">
          {!isGrid && Boolean(element["ShowCaption"]) ? (
            <label className="form-label">{element["DCaption"]}</label>
          ) : null}

          <span className="text-danger"></span>
          <div className="controls">
            <div
              className="input-group input-group-xs form-control p-0"
              data-toggle="popover"
              data-placement="top"
            >
              <span
                className="form-control input-xs boder-end border-0"
                style={{ textOverflow: "ellipsis", overflow: "hidden" }}
                title={fileName?.toString()}
              >
                {!fileName
                  ? "No file selected"
                  : fileName?.toString().includes("#")
                  ? fileName?.toString().split("#")[1]
                  : fileName?.toString()}
              </span>
              <div className="input-group-btn bg-light rounded-3">
                <a
                  className="btn btn-default  btn-icon"
                  title="Download"
                  onClick={handleDownloadFile}
                >
                  <i className="ph ph-download"></i>
                </a>

                <div style={{ display: "none" }}>
                  <input
                    ref={fileInputRef}
                    type="file"
                    accept="*"
                    data-maxfilesize="10485760"
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default DownloadOnly;
