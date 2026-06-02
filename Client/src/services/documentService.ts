// Innovace Intech Solution Pvt Ltd
import { config } from "@/constants/config";
import type {
  IDeleteDocumentFormData,
  IGetDocumentIdFormData,
  IUrlFileResponse,
} from "@/constants/types";
import axiosHelper from "@/helpers/axiosHelper";

export const uploadDocument = async (formData: FormData) => {
  const data = await axiosHelper<IUrlFileResponse>(
    `${config.DOCUMENT_SERVICE_URL}/Values/UploadDocumentViaIspace`,
    "POST",
    formData
  );

  return data;
};

export const ExtractDocumentOcr = async (formData: FormData) => {
  const data = await axiosHelper<IUrlFileResponse>(
    `${config.BASE_EXECUTION_URL}/RemoteGateway/ExtractDocumentOcr`,
    "POST",
    formData
  );

  return data;
}

export const getBase64StringFromUrl = async (
  slotId: string,
  documentId: string,
  versionId: string | number
) => {
  const data = await axiosHelper<IUrlFileResponse>(
    `${config.DOCUMENT_SERVICE_URL}/RemoteGateway/GetDocumentById`,
    "POST",
    {},
    {
      "Content-Type": "application/json",
    },
    {
      slotToken: slotId,
      documentId,
      versionId,
    }
  );

  return data;
};

export const getDocumentIdFromDocument = async (
  formData: IGetDocumentIdFormData
) => {
  const data = await axiosHelper(
    `${config.DOCUMENT_SERVICE_URL}/RemoteGateway/GetDocumentIdByDocumentNumber`,
    "POST",
    formData
  );

  return data;
};

export const deleteDocument = async (formData: IDeleteDocumentFormData) => {
  const data = await axiosHelper<number>(
    `${config.DOCUMENT_SERVICE_URL}/RemoteGateway/DeleteDocument`,
    "POST",
    {},
    {},
    { ...formData }
  );

  return data;
};
