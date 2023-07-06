# **CHUNG**
## **Số mũ:**
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

## **Toán học trong .NET**
Số PI: Math.PI

## **Chỉ 2 chữ số cuối**
().ToString(“F2”);

## **Thêm dấu phân cách trong số**
int number = 100000;
string formattedNumber = number.ToString("N0");
Ký tự "N" trong chuỗi định dạng "N0" đại diện cho chuỗi định dạng số (number format), và số "0" chỉ ra rằng không có số thập phân. Kết quả sẽ là chuỗi "100,000".

## **Chuyển 100,000 thành 100000**
string input = "100.000";
string formattedNumber = input.Replace(".", "");

## **Lấy năm hiện tại:**
int currentYear = DateTime.Now.Year;


# **Xử lý chuổi**
```C#
string fullname = txtHovaten.Text;
int VitriKhoangTrangCuoiCung = fullname.LastIndexOf(" ");
if (!string.IsNullOrEmpty(fullname) && VitriKhoangTrangCuoiCung != -1)
    {
        lbHovaChulot.Text = "Họ và chữ lót: " + fullname.Substring(0, VitriKhoangTrangCuoiCung);
        lbTen.Text = "Tên: " + fullname.Substring(VitriKhoangTrangCuoiCung + 1);
    }
```
 
# **FORM - frm**
* Tạo sự kiện khi nhấn enter

 
# **TextBox - txt**
* Khóa Textbox người dùng chỉ nhập số:
- Tìm Event “KeyPress”
- Thêm code:
```C#
private void tbValueA_KeyPress(object sender, KeyPressEventArgs e)
{
    char ch = e.KeyChar;

    if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
    {
        e.Handled = true;
    }
}
```

## **Chặn người dùng tương tác TextBox**
- Tìm properties: ReadOnly → True


# **Button - btn**
* Khóa
- Chỉnh properties: Enable = false  
CheckBox - chk
* Chỉnh chữ sang bên trái
- Vào properties
- Tìm TextAlign hoặc CheckAlign
- TextAlign = “Right”

 
# **ComboBox - cbb**
* Chặn người dùng chỉnh giá trị:
- Tìm properties: DropDownStyle → DropDownList

 
# **Radio - rdo**
* Chọn 1 radio trong group làm mặt định
- Tìm properties: Checked → True


# **DatePicker - dpk**
* Chỉ hiểm thị năm trong Datepicker
- Thay đổi thuộc tính Format = “Custum”
- Thay đổi thuộc tinhs CustumFormat = “yyyy”


# **DataGridView**


 
Thực thi command
ExecuteNonQuery


ExecuteReader


ExecuteScalar

# **MDI**
- Chọn form Main, vào properties, tìm ***IsMdiContainer*** chỉnh thành **True**

- Vào toolbox, tìm ***MenuStrip***, thêm menu vào

- Tạo form con (child form)

- Tạo event khi nhấn vào menu để mở form con
```C#
<Tên form> <Biến lưu form> = new <Tên form>();
<Biến lưu form>.MdiParent = this;
<Biến lưu form>.Show();
```
 
# **NÂNG CAO**
* Clear hết mọi thông tin trong form
```c#
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
```


# **Các loại kết nối SQL**
**Kiểu 1:** Sử dụng SqlCommand và SqlDataReader

- Ưu điểm:

Đơn giản, dễ hiểu.
Cho phép bạn thực hiện các truy vấn SQL tùy chỉnh mạnh mẽ.
- Nhược điểm:

Cần viết nhiều mã hơn để xử lý các tác vụ như đọc dữ liệu từ SqlDataReader.
Không hỗ trợ tự động theo dõi các thay đổi trong các đối tượng lưu trữ.
Cần viết mã thủ công để chuyển đổi giữa đối tượng và dữ liệu.

**Kiểu 2:** Sử dụng SqlDataAdapter và DataSet
- Ưu điểm:

Cho phép bạn làm việc với dữ liệu ở mức độ cao hơn, không cần phải quan tâm nhiều đến SQL.
Hỗ trợ tự động theo dõi các thay đổi trong các đối tượng lưu trữ.
- Nhược điểm:

Không hỗ trợ trực tiếp các truy vấn LINQ.
Có thể gặp khó khăn khi làm việc với các truy vấn SQL phức tạp.

**Kiểu 3:** Sử dụng LINQ to SQL
- Ưu điểm:

Cho phép bạn làm việc với dữ liệu ở mức độ đối tượng, sử dụng cú pháp LINQ để thao tác dữ liệu.
Hỗ trợ tự động theo dõi các thay đổi trong các đối tượng lưu trữ.
- Nhược điểm:
    -  Chỉ hỗ trợ SQL Server.
    - Không hỗ trợ nhiều tính năng mà các ORM khác như Entity Framework hỗ trợ.
    
Mỗi phương pháp đều phù hợp với các tình huống khác nhau, do đó, bạn nên chọn phương pháp phù hợp nhất với nhu cầu của dự án của bạn.