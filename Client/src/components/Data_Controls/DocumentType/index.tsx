// Innovace Intech Solution Pvt Ltd
import React from "react";

import type { UIElement } from "../../../constants/types";
import View from "./ViewOnly";
import UploadOnly from "./UploadOnly";
import Explore from "./ExplorerView";
import TabList from "./TabListView";
import InlineSingle from "./InlineSingle";
import UploadAndView from "./UplodeAndView";
import InlineMultiple from "./InlineMultiSelect";
import ViewAndDownload from "./ViewAndDownload";
import DownloadOnly from "./DownloadOnly";
import UploadControl from "./UploadControl";
import Upload from "./Upload";

const DocumentType: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  switch (element.RenderType) {
    case 4:
      return <InlineSingle element={element} isGrid={isGrid} />;
    case 5:
      return <InlineMultiple element={element} isGrid={isGrid} />;
    case 6:
      return <Explore element={element} isGrid={isGrid} />;
    case 7:
      return <TabList element={element} isGrid={isGrid} />;
    case 8:
      return <UploadControl element={element} isGrid={isGrid} />;
    case 21:
      return <Upload element={element} isGrid={isGrid} />;
    case 22:
      return <UploadAndView element={element} isGrid={isGrid} />;
    case 23:
      return <View element={element} isGrid={isGrid} />;
    case 30:
      return <UploadOnly element={element} isGrid={isGrid} />;
    case 31:
      return <DownloadOnly element={element} isGrid={isGrid} />;
    case 32:
      return <ViewAndDownload element={element} isGrid={isGrid} />;
    default:
      return null;
  }
};

export default DocumentType;
