# CHUNG
* Số mũ:
yourLabel.Text = "3\u00B2 = 9"; // Mũ 2
•	\u00B2 cho số 2
•	\u00B3 cho số 3
•	\u2074 cho số 4
•	\u2075 cho số 5
•	\u2076 cho số 6
•	\u2077 cho số 7
•	\u2078 cho số 8
•	\u2079 cho số 9

Chỉnh trong properties: ²

* Toán học trong .NET
Số PI: Math.PI

* Chỉ 2 chữ số cuối 
().ToString(“F2”);

* Thêm dấu phân cách trong số
int number = 100000;
string formattedNumber = number.ToString("N0");
Ký tự "N" trong chuỗi định dạng "N0" đại diện cho chuỗi định dạng số (number format), và số "0" chỉ ra rằng không có số thập phân. Kết quả sẽ là chuỗi "100,000".

* Chuyển 100,000 thành 100000
string input = "100.000";
string formattedNumber = input.Replace(".", "");

* Lấy năm hiện tại:
int currentYear = DateTime.Now.Year;
---
 
# FORM - frm
* Tạo sự kiện khi nhấn enter


---
 
TextBox
* Khóa Textbox người dùng chỉ nhập số:
- Tìm Event “KeyPress”
- Thêm code:
private void tbValueA_KeyPress(object sender, KeyPressEventArgs e)
{
    char ch = e.KeyChar;

    if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
    {
        e.Handled = true;
    }
}

* Chặn người dùng tương tác TextBox
- Tìm properties: ReadOnly → True
---
 
Button - btn
* Khóa
- Chỉnh properties: Enable = false  
CheckBox - chk
* Chỉnh chữ sang bên trái
- Vào properties
- Tìm TextAlign hoặc CheckAlign
- TextAlign = “Right”

---
 
ComboBox - cbb
* Chặn người dùng chỉnh giá trị:
- Tìm properties: DropDownStyle → DropDownList
---
 
Radio
* Chọn 1 radio trong group làm mặt định
- Tìm properties: Checked → True



 
DatePicker - dpk
* Chỉ hiểm thị năm trong Datepicker
- Thay đổi thuộc tính Format = “Custum”
- Thay đổi thuộc tinhs CustumFormat = “yyyy”


 
DataGridView

---

 
Thực thi command
ExecuteNonQuery


ExecuteReader


ExecuteScalar

 
NÂNG CAO
* Clear hết mọi thông tin trong form
private void ClearControls(Control control)
{
    foreach (Control c in control.Controls)
    {
        // Clear text boxes
        if (c is TextBox)
        {
            ((TextBox)c).Clear();
        }
        // Clear checkboxes
        else if (c is CheckBox)
        {
            ((CheckBox)c).Checked = false;
        }
        // Clear radio buttons
        else if (c is RadioButton)
        {
            ((RadioButton)c).Checked = false;
        }
        // Clear combo boxes
        else if (c is ComboBox)
        {
            ((ComboBox)c).SelectedIndex = -1;
        }
        // Clear date time pickers
        else if (c is DateTimePicker)
        {
            ((DateTimePicker)c).ResetText();
        }

        // Recursively call this method for each container control
        if (c.HasChildren)
        {
            ClearControls(c);
        }
    }
}
