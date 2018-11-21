@ModelType CBIR.BangSanPham
@Code
    ViewData("Title") = "Chi tiết sản phẩm"
End Code

<h2>Chi tiết sản phẩm</h2>

<div>
    <h4>Sản phẩm</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Mã sản phẩm
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaSP)
        </dd>

        <dt>
            Tên sản phẩm
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenSP)
        </dd>

        <dt>
            Giá bán
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaBan)
        </dd>

        <dt>
            Giá gốc
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaGoc)
        </dd>

        <dt>
            Giá góp
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaGop)
        </dd>

        <dt>
            Số lượng tồn
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SoLuongTon)
        </dd>

        <dt>
            Tên loại
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LoaiSanPham.TenLoai)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Sửa", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Quay lại", "Index")
</p>
