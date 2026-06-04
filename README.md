## Luồng hoạt động
1. Người dùng mở form thêm sách.
2. Nhập tên sách và giá.
3. Nhấn nút **Thêm**.
4. Controller nhận dữ liệu.
5. Data Annotation kiểm tra dữ liệu.
6. Kết quả được lưu vào ModelState.
7. Nếu hợp lệ thì thêm vào danh sách.
8. Nếu không hợp lệ thì hiển thị lỗi.
## Điều kiện kiểm tra
| Điều kiện | Thông báo |
|-----------|-----------|
| Tên rỗng | Không được để trống |
| Giá <= 0 | Giá phải lớn hơn 0 |
## Data Annotation
```csharp
[Required(ErrorMessage = "Không được để trống")]
public string Name { get; set; }

[Range(0.01, double.MaxValue,
    ErrorMessage = "Giá phải lớn hơn 0")]
public double Price { get; set; }
```
## ModelState
```csharp
if (ModelState.IsValid)
{
    books.Add(book);
}
```
- `true`: Dữ liệu hợp lệ.
- `false`: Dữ liệu không hợp lệ.
## Kết quả
- Không cho phép tên sách rỗng.
- Không cho phép giá nhỏ hơn hoặc bằng 0.
- Hiển thị lỗi trực tiếp trên form.
- Chỉ lưu dữ liệu khi hợp lệ.
- [Video cho buổi 5](https://www.loom.com/share/9f2ab667ba8e4013af0ca0a83eba3e0a)
