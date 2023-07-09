Dưới đây là đề thi chi tiết hơn dựa trên cấu trúc bạn đã cung cấp:

**Phần I: CSDL – 2.0 điểm**

1. Tạo CSDL theo yêu cầu

   - Tạo CSDL "QuanLyLopHoc" gồm các bảng sau: "SinhVien", "LopHoc", "SuKien", "ThamGia"
   
   - Mô tả các bảng:
        - "SinhVien" gồm các cột: MaSV (string, primary key), HoTen (string), NgaySinh (date), Email (string, unique)
        - "LopHoc" gồm các cột: MaLH (string, primary key), TenLH (string), SoSinhVien (int, check > 0)
        - "SuKien" gồm các cột: MaSK (string, primary key), TenSK (string), ThoiGian (datetime), DiaDiem (string)
        - "ThamGia" gồm các cột: MaSV (string, foreign key with SinhVien), MaSK (string, foreign key with SuKien)
        
    - Thêm mẫu tin cho các bảng.

**Phần II: Ứng dụng hệ thống quản lý thông tin – 6.0 điểm**

1. Thiết kế các form cho hệ thống quản lý thông tin
    - Thiết kế form "QuanLySinhVien", "QuanLySuKien", và "DangNhap".
    
2. Thao tác dữ liệu với ADO.NET
    - Trên form "QuanLySinhVien": thêm, sửa, xóa, hiển thị thông tin sinh viên. 
    - Trên form "QuanLySuKien": thêm, sửa, xóa, hiển thị thông tin sự kiện. Đồng thời, cho phép thêm, sửa, xóa sự tham gia của sinh viên vào sự kiện.
    - Trên form "DangNhap": Kiểm tra thông tin đăng nhập của người dùng.
    
3. Xử lý lỗi và ngoại lệ
    - Xử lý lỗi khi kết nối đến CSDL, thực hiện các thao tác trên CSDL.
    - Xử lý ngoại lệ khi nhập dữ liệu không đúng định dạng, nhập dữ liệu trùng lặp.

**Phần III: Phân quyền hệ thống – 2.0 điểm**

1. Phân quyền chức năng dựa trên quyền người dùng truy cập
    - Tạo 2 loại tài khoản đăng nhập: "admin", "user".
    - "admin" có toàn quyền trên hệ thống, "user" chỉ có quyền xem thông tin.
    - Thực hiện chức năng đăng nhập và phân quyền cho người dùng.

Đề thi yêu cầu sinh viên phải hiểu rõ về cách thiết kế và thao tác với CSDL, cũng như việc xây dựng giao diện và phân quyền cho người dùng trong ứng dụng .NET.