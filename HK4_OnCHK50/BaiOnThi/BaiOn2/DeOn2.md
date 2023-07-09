Đề thi thực hành .NET (TH1337)

Chủ đề: Trường Đại Học

Phần I: Cơ Sở Dữ Liệu (CSDL) - 2.0 điểm 

**1.1. Tạo CSDL theo yêu cầu:**

- [X] Tạo ba bảng chính: SinhVien, MonHoc, DiemThi (để thực hành 3 loại kết nối: SqlCommand và SqlDataReader; SqlDataAdapter và DataSet; LINQ to SQL).

    **- [X] Bảng SinhVien:**

        ID (int, primary key): ID duy nhất để xác định mỗi sinh viên.

        HoTen (varchar): Tên của sinh viên.

        NgaySinh (date): Ngày sinh của sinh viên.

        GioiTinh (boolean): Giới tính của sinh viên.

        Email (varchar, unique): Email của sinh viên.

    **- [X] Bảng MonHoc:**

        ID (int, primary key): ID duy nhất để xác định mỗi môn học.

        TenMonHoc (varchar): Tên môn học.

        SoTinChi (int): Số tín chỉ của môn học.

        HocKy (int): Học kỳ mà môn học được mở.

    **- [X] Bảng DiemThi:**

        ID (int, primary key): ID duy nhất để xác định mỗi bảng điểm.

        SinhVienID (int, foreign key references SinhVien(ID)): ID của sinh viên đã tham gia môn học và có bảng điểm.

        MonHocID (int, foreign key references MonHoc(ID)): ID của môn học mà sinh viên đã tham gia và có bảng điểm.

        Diem (float): Điểm thi của sinh viên cho môn học tương ứng.


- [X] Thiết lập ràng buộc dữ liệu cho mỗi bảng (primary key, unique, foreign key, check...)
- [ez] Tạo mẫu tin cho mỗi bảng.

**1.2. (Độ khó cao) Tạo stored procedure và trigger:**
- [x] Tạo một stored procedure để lấy thông tin chi tiết của một sinh viên dựa trên ID.
- [Khó] Tạo trigger để tự động cập nhật tổng số tín chỉ của một sinh viên khi có thay đổi trong bảng DiemThi.

**Phần II: Ứng dụng hệ thống quản lý thông tin – 6.0 điểm**

**2.1. Thiết kế các form cho hệ thống quản lý thông tin:**

- [X] Form "Quản lý sinh viên": Thêm, sửa, xóa, hiển thị danh sách sinh viên. Sử dụng textbox để nhập dữ liệu, datetimepicker để chọn ngày sinh.
    - Thêm
    - Sửa
    - Xóa
    - Hiểm thị

- [X] Form "Quản lý môn học": Thêm, sửa, xóa, hiển thị danh sách môn học. Sử dụng textbox để nhập dữ liệu, checkbox để xác định môn học có khả năng đăng ký hay không.
    - Thêm
    - Sửa
    - Xóa
    - Hiểm thị

- Form "Quản lý điểm": Thêm, sửa, xóa, hiển thị điểm thi của sinh viên. Sử dụng textbox để nhập dữ liệu.
    - [X] Thêm
    - [X] Sửa
    - [X] Xóa
    - [X] Hiểm thị

**2.2. Thao tác dữ liệu với ADO.NET:**

- [X] Trong mỗi form, thực hiện các thao tác: Thêm, sửa, xóa, hiển thị dữ liệu từ CSDL.
- [X] Cho phép thêm, sửa, xóa nhiều mẩu tin cùng lúc.
- Dịch chuyển giữa các mẩu tin trong danh sách: về đầu, về trước, về sau, về cuối.

**2.3. (Độ khó cao) Thực hiện thao tác phức tạp với ADO.NET:**

- [X] Tạo chức năng tìm kiếm sinh viên dựa trên tên hoặc ID. Kết quả tìm kiếm phải cung cấp thông tin chi tiết của sinh viên đó.
- Tạo chức năng thống kê, bao gồm: tính tổng số sinh viên, tổng số môn học, điểm trung bình của mỗi sinh viên.

**2.4. (Độ khó cao) Xử lý lỗi và ngoại lệ:**

- Xử lý các lỗi và ngoại lệ có thể xảy ra khi kết nối đến CSDL, thực hiện các thao tác trên CSDL.
- Tạo các thông báo lỗi rõ ràng để người dùng biết được tình trạng của hệ thống.
    + Lỗi kết nối đến cơ sở dữ liệu: Nếu chương trình không thể kết nối đến cơ sở dữ liệu, bạn nên thông báo cho người dùng với một thông báo lỗi phù hợp, chẳng hạn như "***Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại kết nối mạng của bạn***".
    + Lỗi khi truy vấn dữ liệu: Nếu một truy vấn SQL gặp lỗi, bạn nên thông báo cho người dùng với một thông báo như "***Có lỗi khi truy xuất dữ liệu từ cơ sở dữ liệu***".
    + Lỗi khi nhập dữ liệu không hợp lệ: Nếu người dùng nhập dữ liệu không hợp lệ, bạn nên thông báo với họ một cách rõ ràng về vấn đề, ví dụ: "ID sinh viên không được để trống" hoặc "**Điểm thi phải là một số từ 0 đến 10**".
    + Lỗi khi cố gắng cập nhật hoặc xóa một mẩu tin không tồn tại: "***Không tìm thấy sinh viên với ID đã cho***".
    + Lỗi trùng lặp dữ liệu, ví dụ khi thêm một sinh viên có ID đã tồn tại: "***Một sinh viên với ID này đã tồn tại trong cơ sở dữ liệu***".

**Phần III: Phân quyền hệ thống – 2.0 điểm**

**3.1. Phân quyền chức năng:**

- Phân quyền chức năng dựa trên quyền người dùng truy cập (Admin, User).
- Admin có toàn quyền thêm, sửa, xóa. User chỉ được xem thông tin.
- Có thể phân quyền menu trong cửa sổ chính của ứng dụng MDI, hoặc phân quyền truy cập Form đơn nếu không cho ứng dụng MDI.

**3.2. (Độ khó cao) Mô phỏng tình huống thực tế:**

- Tạo một form đăng nhập với vai trò Admin hoặc User.
- Tùy vào vai trò đã đăng nhập, các chức năng trên form sẽ được hiển thị hoặc ẩn đi tương ứng.

Lưu ý: Mỗi phần đều yêu cầu bạn viết mã nguồn đầy đủ và có giải thích cho từng phần của mã nguồn. Điểm sẽ được chấm dựa trên độ chính xác, tính hiệu quả và phong cách viết mã của bạn. Các mục đánh dấu "Độ khó cao" yêu cầu kỹ năng lập trình nâng cao và hiểu biết sâu sắc về .NET và CSDL.