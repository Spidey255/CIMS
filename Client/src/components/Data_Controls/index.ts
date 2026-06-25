import React from "react";

import Column from "@/components/UI_Controls/Column";
import TextBox from "@/components/Data_Controls/TextBox";
import NumericTextBox from "@/components/Data_Controls/NumericTextBox";
import CheckBox from "@/components/Data_Controls/CheckBox";
import ComboBox from "@/components/Data_Controls/ComboBox";
import DateTimePicker from "@/components/Data_Controls/DateTimePicker";
import DocumentType from "@/components/Data_Controls/DocumentType";
import ActionButton from "@/components/Data_Controls/ActionButton";


export const componentsMap: { [key: string]: React.FC<any> } = {
  18: Column,
  1: TextBox,
  2: NumericTextBox,
  3: CheckBox,
  5: ComboBox,
  7: DateTimePicker,
  8: DocumentType,
  9: ActionButton
};