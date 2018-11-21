@ModelType IEnumerable(Of CBIR.BangSanPham)
@Code
    ViewData("Title") = "Bảng sản phẩm"
End Code

<h2>Bảng sản phẩm</h2>

<p>
    @Html.ActionLink("Thêm mới", "Create")
</p>
<table class="table table-striped table-bordered table-hover warning">
    <tr>
        <th>
            Mã sản phẩm
        </th>
        <th>
            Tên sản phẩm
        </th>
        <th>
            Giá bán
        </th>
        <th>
            Giá gốc
        </th>
        <th>
            Giá góp
        </th>
        <th>
            Số lượng tồn
        </th>
        <th>
            Tên loại
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaSP)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenSP)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GiaBan)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GiaGoc)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GiaGop)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SoLuongTon)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LoaiSanPham.TenLoai)
        </td>
        <td>
            @Html.ActionLink("Sửa", "Edit", New With {.id = item.id}) |
            @Html.ActionLink("Chi tiết", "Details", New With {.id = item.id}) |
            @Html.ActionLink("Xóa", "Delete", New With {.id = item.id})
        </td>
    </tr>
Next

</table>
