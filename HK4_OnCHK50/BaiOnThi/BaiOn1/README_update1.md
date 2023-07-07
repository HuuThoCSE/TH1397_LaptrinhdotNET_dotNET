Dưới đây là phiên bản cập nhật của đề thi .NET, trong đó tôi đã thêm các yêu cầu cho form quản lý môn học của một giảng viên cụ thể, cũng như form quản lý quyền người dùng:

---

## Đề Thi Thực Hành .NET (TH1337)

Thời gian làm bài: 3 giờ

### Phần I: CSDL – 2.0 điểm

1. (2.0 điểm) Tạo CSDL "SchoolManagement" dựa trên yêu cầu sau:

a. Dựa trên Database Diagram sau:

- Bảng `Students`: `StudentID (int, PK, Identity)`, `Name (nvarchar(50))`, `Age (int)`, `ClassID (int, FK)`

- Bảng `Classes`: `ClassID (int, PK, Identity)`, `ClassName (nvarchar(50))`, `TeacherID (int, FK)`

- Bảng `Teachers`: `TeacherID (int, PK, Identity)`, `Name (nvarchar(50))`

- Bảng `Subjects`: `SubjectID (int, PK, Identity)`, `SubjectName (nvarchar(50))`

- Bảng `TeacherSubjects`: `TeacherID (int, FK)`, `SubjectID (int, FK)`

b. Thiết lập ràng buộc dữ liệu cho các bảng (primary key, unique, foreign key, check).

c. Import hoặc chạy script để tạo CSDL.

d. Thêm ít nhất 5 mẫu tin cho mỗi bảng.

### Phần II: Ứng dụng hệ thống quản lý thông tin – 7.0 điểm

2. (2.0 điểm) Thiết kế các form cho hệ thống quản lý thông tin của trường học:

a. Form "Manage Students": Thêm, sửa, xóa, hiển thị danh sách học sinh.

b. Form "Manage Classes": Thêm, sửa, xóa, hiển thị danh sách lớp học.

c. Form "Manage Teachers": Thêm, sửa, xóa, hiển thị danh sách giáo viên.

d. Form "Manage Teacher Subjects": Chọn một giáo viên cụ thể và quản lý các môn học mà giáo viên này dạy.

e. Form "Manage User Roles": Quản lý quyền người dùng, cho phép thêm, xóa và chỉnh sửa quyền cho từng loại tài khoản.

3. (5.0 điểm) Thao tác dữ liệu với ADO.NET:

a. Trên Form "Manage Students", thực hiện các chức năng sau:

- Kiểm tra dữ liệu (chỉ cho phép nhập tuổi từ 6-18).

- Thêm, sửa, xóa học sinh.

- Hiển thị danh sách học sinh.

- Dịch chuyển giữa các mẩu tin: về đầu, về trước, về sau, về cuối.

b. Trên Form "Manage Classes", thực hiện các chức năng sau:

- Thêm, sửa, xóa lớp học.

- Hiển thị danh sách lớp học.

c. Trên Form "Manage Teachers", thực hiện các chức năng sau:

- Thêm, sửa, xóa giáo viên.

- Hiển thị danh sách giáo viên.

d. Trên Form "Manage Teacher Subjects", thực hiện các chức năng sau:

- Chọn giáo viên từ danh sách.

- Thêm, xóa môn học cho giáo viên đã chọn.

e. Trên Form "Manage User Roles", thực hiện các chức năng sau:

- Thêm, xóa, chỉnh sửa quyền cho từng loại tài khoản (Admin, Teacher).

### Phần III: Phân quyền hệ thống – 3.0 điểm

4. (3.0 điểm) Phân quyền chức năng dựa trên quyền người dùng truy cập:

a. Tạo các loại tài khoản: Admin, Teacher.

b. Phân quyền menu trong cửa sổ chính của ứng dụng MDI dựa trên loại tài khoản:

- Admin: có quyền truy cập vào tất cả các form.

- Teacher: chỉ có quyền truy cập vào Form "Manage Classes", "Manage Students" và "Manage Teacher Subjects".

### Yêu cầu chung:

- Code phải rõ ràng, sạch sẽ và có chú thích cần thiết.
- Giao diện người dùng phải thân thiện và dễ sử dụng.
- Kết nối CSDL phải đảm bảo an toàn và hiệu quả.
- Cần có xử lý lỗi cơ bản để ngăn chặn crash ứng dụng.

### Nộp bài:

- Nén toàn bộ source code, script tạo CSDL và file CSDL (nếu có) thành file zip/rar.
- Đặt tên file theo mẫu: `TH1337_HọTên_MSSV.zip` (hoặc `.rar`).
- Nộp file qua hệ thống quản lý học tập trực tuyến hoặc theo hướng dẫn của giáo viên.

### Chúc bạn thành công!
---