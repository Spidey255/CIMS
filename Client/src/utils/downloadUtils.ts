// Innovace Intech Solution Pvt Ltd
import * as XLSX from "xlsx";
import jsPDF from "jspdf";
import autoTable from "jspdf-autotable";
import type { ServiceElementData, UIElement } from "../constants/types";
import { getValidColumns } from "@/helpers/gridHelpers";

/**
 * Downloads grid data as Excel file
 * @param gridData - Array of ServiceElementData representing grid rows
 * @param gridInfo - UIElement containing grid information
 * @param gridHeaders - Optional UIElement[] array of grid headers. If not provided, will try to get from store.
 */
export const downloadAsExcel = async (
  gridData: ServiceElementData[],
  gridInfo: UIElement,
  gridHeaders?: UIElement[]
): Promise<void> => {
  try {
    let headers: UIElement[] = [];
    
    if (gridHeaders) {
      headers = getValidColumns(gridHeaders) || [];
    } else {
      // Fallback: try to get from store dynamically
      const { useGridStore } = await import("@/store/useGridStore");
      const gridHeader = useGridStore.getState().gridHeader;
      const parentId = gridInfo.ParentElementId || "";
      headers = getValidColumns(gridHeader[parentId]) || [];
    }
    
    if (!headers.length || !gridData.length) {
      console.warn("No headers or data to export");
      return;
    }

    // Prepare Excel data
    const excelData: any[] = [];

    // Add header row
    const headerRow = headers.map((header) => header.DCaption || header.DisplayName || header.ElementName);
    excelData.push(headerRow);

    // Add data rows
    gridData.forEach((row) => {
      if (row.Child && row.Child.length > 0) {
        const dataRow = headers.map((header) => {
          const cell = row.Child?.find((child) => child.ElementName === header.ElementName);
          const value = cell?.Value;
          
          // Convert value to string, handling null/undefined
          if (value === null || value === undefined) {
            return "";
          }
          if (typeof value === "object") {
            return JSON.stringify(value);
          }
          return String(value);
        });
        excelData.push(dataRow);
      }
    });

    // Create workbook and worksheet
    const wb = XLSX.utils.book_new();
    const ws = XLSX.utils.aoa_to_sheet(excelData);

    // Set column widths
    const colWidths = headers.map(() => ({ wch: 20 }));
    ws["!cols"] = colWidths;

    // Add worksheet to workbook
    XLSX.utils.book_append_sheet(wb, ws, "Grid Data");

    // Generate file name
    const fileName = `${gridInfo.ElementName || "grid_data"}_${new Date().toISOString().split("T")[0]}.xlsx`;

    // Download file
    XLSX.writeFile(wb, fileName);
  } catch (error) {
    console.error("Error exporting to Excel:", error);
    throw error;
  }
};

/**
 * Downloads grid data as PDF file in table format
 * @param gridData - Array of ServiceElementData representing grid rows
 * @param gridInfo - UIElement containing grid information
 * @param gridHeaders - Optional UIElement[] array of grid headers. If not provided, will try to get from store.
 */
export const downloadAsPDF = async (
  gridData: ServiceElementData[],
  gridInfo: UIElement,
  gridHeaders?: UIElement[]
): Promise<void> => {
  try {
    let headers: UIElement[] = [];
    
    if (gridHeaders) {
      headers = getValidColumns(gridHeaders) || [];
    } else {
      // Fallback: try to get from store dynamically
      const { useGridStore } = await import("@/store/useGridStore");
      const gridHeader = useGridStore.getState().gridHeader;
      const parentId = gridInfo.ParentElementId || "";
      headers = getValidColumns(gridHeader[parentId]) || [];
    }
    
    if (!headers.length || !gridData.length) {
      console.warn("No headers or data to export");
      return;
    }

    // Create PDF document
    const doc = new jsPDF();

    // Prepare table data
    const tableHeaders = headers.map((header) => header.DCaption || header.DisplayName || header.ElementName);
    const tableRows: string[][] = [];

    // Process grid data
    gridData.forEach((row) => {
      if (row.Child && row.Child.length > 0) {
        const dataRow = headers.map((header) => {
          const cell = row.Child?.find((child) => child.ElementName === header.ElementName);
          const value = cell?.Value;
          
          // Convert value to string, handling null/undefined
          if (value === null || value === undefined) {
            return "";
          }
          if (typeof value === "object") {
            return JSON.stringify(value);
          }
          return String(value);
        });
        tableRows.push(dataRow);
      }
    });

    // Add title
    const title = gridInfo.DCaption || gridInfo.DisplayName || gridInfo.ElementName || "Grid Data";
    doc.setFontSize(16);
    doc.text(title, 14, 15);

    // Add table using autoTable
    autoTable(doc, {
      head: [tableHeaders],
      body: tableRows,
      startY: 25,
      styles: { fontSize: 8, cellPadding: 3 },
      headStyles: { fillColor: [66, 139, 202], textColor: 255, fontStyle: "bold" },
      alternateRowStyles: { fillColor: [245, 245, 245] },
      margin: { top: 20 },
      tableWidth: "wrap",
    });

    // Generate file name
    const fileName = `${gridInfo.ElementName || "grid_data"}_${new Date().toISOString().split("T")[0]}.pdf`;

    // Save PDF
    doc.save(fileName);
  } catch (error) {
    console.error("Error exporting to PDF:", error);
    throw error;
  }
};
