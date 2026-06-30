import React from "react";

import Column from "@/components/UI_Controls/Column";
import ComboBox from "@/components/Data_Controls/ComboBox";
import CheckBox from "@/components/Data_Controls/CheckBox";
import DateTimePicker from "@/components/Data_Controls/DateTimePicker";
import NumericTextBox from "@/components/Data_Controls/NumericTextBox";
import ActionButton from "@/components/Data_Controls/ActionButton";
import DocumentType from "@/components/Data_Controls/DocumentType";
import TextBox from "@/components/Data_Controls/TextBox";


export const componentsMap: { [key: string]: React.FC<any> } = {
  18: Column,
  5: ComboBox,
  3: CheckBox,
  7: DateTimePicker,
  2: NumericTextBox,
  9: ActionButton,
  8: DocumentType,
  1: TextBox
};