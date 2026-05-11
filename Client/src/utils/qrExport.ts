// Innovace Intech Solution Pvt Ltd
import jsPDF from "jspdf";
import * as htmlToImage from "html-to-image";

export const generateQRImage = async (node: HTMLElement) => {
    return await htmlToImage.toPng(node, {
        cacheBust: true,
        pixelRatio: 2, // 👈 sharp image (pro tip)
    });
};

export const downloadQRAsPDF = async (node: HTMLElement) => {
    const imgData = await generateQRImage(node);

    const pdf = new jsPDF({
        orientation: "portrait",
        unit: "mm",
        format: "a4",
    });

    const imgProps = pdf.getImageProperties(imgData);
    const pdfWidth = 180;
    const pdfHeight = (imgProps.height * pdfWidth) / imgProps.width;

    // center align
    const x = (210 - pdfWidth) / 2;
    const y = (297 - pdfHeight) / 2;

    pdf.addImage(imgData, "PNG", x, y, pdfWidth, pdfHeight);
    pdf.save("qr-code.pdf");
};

export const shareQR = async (node: HTMLElement) => {
    const dataUrl = await generateQRImage(node);

    const blob = await (await fetch(dataUrl)).blob();
    const file = new File([blob], "qr-code.png", { type: blob.type });

    if (navigator.canShare && navigator.canShare({ files: [file] })) {
        await navigator.share({
            title: "QR Code",
            text: "Scan this QR",
            files: [file],
        });
    } else {
        // fallback
        const link = document.createElement("a");
        link.href = dataUrl;
        link.download = "qr-code.png";
        link.click();
    }
};