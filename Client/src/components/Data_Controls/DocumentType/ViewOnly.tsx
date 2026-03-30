// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useState } from "react";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { getExtensionFromBase64 } from "@/helpers/utils";
import { getBase64StringFromUrl } from "@/services/documentService";
import { DocumentViewerModal } from "@/components/DocumentViewer";

const View: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const slotId = useUserStore((store) => store.slotId);
  const [base64Data, setBase64Data] = useState<string>();
  const [isModalOpen, setIsModalOpen] = useState(false);
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
          // setFileType(extension);
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

  return (
    <div
      className={element.ColumnCss}
      id={element.ElementName}
      onClick={(e) => e.stopPropagation()}
    >
      <div className="form-group">
        {!isGrid && Boolean(element["ShowCaption"]) ? (
          <label className="form-label">{element["DCaption"]}</label>
        ) : null}
        <span id={`man_${element.ElementName}`} className="text-danger"></span>
        <div className="controls">
          <div
            className="input-group input-group-xs form-control p-0" 
            data-toggle="popover"
            data-placement="top"
          >
            <span
              className="form-control input-xs border-end border-0"
              style={{ textOverflow: "ellipsis", overflow: "hidden" }}
              title={fileName}
            >
              {fileName || "No file"}
            </span>
            <div className="input-group-btn bg-light rounded-3">
              <a
                className="btn btn-default btn-icon"
                title="View"
                onClick={() => setIsModalOpen(true)}
              >
                <i className="ph ph-arrow-square-out"></i>
              </a>
              {/* View Button */}
              {/* <Viewer fileType={fileType} base64Data={base64Data} /> */}
              {/* Clear Button */}
              {/* <a
                className="btn btn-default dropdown-toggle btn-icon"
                title="Clear"
              >
                <i className="fa fa-times"></i>
              </a> */}
              {/* Hidden File Input */}
              <div style={{ display: "none" }}>
                <input
                  type="file"
                  id={`inp_${element.ElementName}`}
                  accept=".pdf"
                  data-maxfilesize="10485760"
                  // onChange={handleFileChange}
                />
              </div>
            </div>
          </div>
        </div>
      </div>
      <DocumentViewerModal
        isOpen={isModalOpen}
        onClose={() => setIsModalOpen(false)}
        base64Data={base64Data || ""}
      />
    </div>
  );
};

export default View;
