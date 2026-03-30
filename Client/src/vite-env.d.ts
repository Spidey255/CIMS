// Innovace Intech Solution Pvt Ltd
/// <reference types="vite/client" />

interface ImportMetaEnv {
  readonly VITE_BASE_URL: string;
  readonly VITE_AUTH_URL: string;
  readonly VITE_DOCUMENT_SERVICE_URL: string;
}

interface ImportMeta {
  readonly env: ImportMetaEnv;
}
