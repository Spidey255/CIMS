// Innovace Intech Solution Pvt Ltd
import React from "react";
import DocumentType from "@/components/Data_Controls/DocumentType";
import ActionButton from "@/components/Data_Controls/ActionButton";
import TextBox from "@/components/Data_Controls/TextBox";
import NumericTextBox from "@/components/Data_Controls/NumericTextBox";
import CheckBox from "@/components/Data_Controls/CheckBox";
import Column from "../UI_Controls/Column";
import ComboBox from "./ComboBox";
import DateTimePicker from "@/components/Data_Controls/DateTimePicker";

export const componentsMap: { [key: string]: React.FC<any> } = {
  8: DocumentType,
  9: ActionButton,
  1: TextBox,
  2: NumericTextBox,
  12:ComboBox,
  3: CheckBox,
  18:Column,
  7:DateTimePicker

};
