// Innovace Intech Solution Pvt Ltd
// Innovace Intech Solution Pvt Ltd

/**
 * Converts PHP date format tokens to Day.js format tokens.
 * Example:
 * d-m-Y      -> DD-MM-YYYY
 * d/m/Y      -> DD/MM/YYYY
 * d F Y      -> DD MMMM YYYY
 * d-m-Y H:i  -> DD-MM-YYYY HH:mm
 */
export const convertPhpToDayjsFormat = (
  format: string = "Y-m-d"
): string => {
  const formatMap: Record<string, string> = {
    // Day
    d: "DD",
    j: "D",
    D: "ddd",
    l: "dddd",

    // Month
    m: "MM",
    n: "M",
    M: "MMM",
    F: "MMMM",

    // Year
    Y: "YYYY",
    y: "YY",

    // Time
    H: "HH",
    G: "H",
    h: "hh",
    g: "h",
    i: "mm",
    s: "ss",
    A: "A",
    a: "a",
  };

  return format.replace(
    /d|j|D|l|m|n|M|F|Y|y|H|G|h|g|i|s|A|a/g,
    (token) => formatMap[token] ?? token
  );
};