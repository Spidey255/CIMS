// Innovace Intech Solution Pvt Ltd
// const BASE_URL = "http://210.18.135.72:5011/api";

// export const config = {
//   BASE_URL,
//   AUTH_URL: `http://210.18.135.72/iProofService/api/RemoteGateway/AuthenticateUser`,
//   DOCUMENT_SERVICE_URL: `http://210.18.135.72/iProofService/api`,
//   SAVE_WIDGET_URL: `${BASE_URL}/iProofServicesHub/SaveWidgetInstanceData`,
//   GET_GRID_INSTANCE_URL: `${BASE_URL}/iProofServicesHub/GetGridInstanceData`,
//   DELETE_GRID_INSTANCE_DATA_URL: `${BASE_URL}/iProofServicesHub/DeleteGridInstanceData`,
  
//   SUPPORTED_IMAGE_FORMAT: ["jpeg", "jpg", "png", "svg", "webp"],
//   SUPPORTED_VIDEO_FORMAT: ["mp4", "webp", "ogg"],
//   SUPPORTED_PDF_FORMAT: ["pdf"],
//   SUPPORTED_DOCUMENT_FORMAT: ["docx"],
//   SUPPORTED_SPREADSHEET_FORMAT: ["xlsx", "xls"],

//   DataControlIds: [1, 2, 3, 4, 5, 6, 7, 8, 13, 14, 66, 67, 68, 76],
// };



const BASE_URL = import.meta.env.VITE_BASE_URL as string;
const AUTH_URL = import.meta.env.VITE_AUTH_URL as string;
const DOCUMENT_SERVICE_URL = import.meta.env.VITE_DOCUMENT_SERVICE_URL as string;
const INBOX_SETTING_ID = import.meta.env.VITE_INBOX_SETTING_ID as string;

export const config = {
  BASE_URL,
  AUTH_URL,
  DOCUMENT_SERVICE_URL,

  SAVE_WIDGET_URL: `${BASE_URL}/iProofServicesHub/SaveWidgetInstanceData`,
  GET_GRID_INSTANCE_URL: `${BASE_URL}/iProofServicesHub/GetGridInstanceData`,
  DELETE_GRID_INSTANCE_DATA_URL: `${BASE_URL}/iProofServicesHub/DeleteGridInstanceData`,
  INBOX_SETTING_ID,

  SUPPORTED_IMAGE_FORMAT: ["jpeg", "jpg", "png", "svg", "webp"],
  SUPPORTED_VIDEO_FORMAT: ["mp4", "webp", "ogg"],
  SUPPORTED_PDF_FORMAT: ["pdf"],
  SUPPORTED_DOCUMENT_FORMAT: ["docx"],
  SUPPORTED_SPREADSHEET_FORMAT: ["xlsx", "xls"],

  DataControlIds: [1, 2, 3, 4, 5, 6, 7, 8, 13, 14, 66, 67, 68, 76, 81],
};

