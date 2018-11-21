@ModelType CBIR.BangSanPham
@Code
    ViewData("Title") = "Xóa sản phẩm"
End Code

<h2>Xóa</h2>

<h3>Bạn có muốn xóa?</h3>
<div>
    <h4>Sản phẩm</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaSP)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaSP)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TenSP)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenSP)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GiaBan)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaBan)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GiaGoc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaGoc)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GiaGop)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiaGop)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SoLuongTon)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SoLuongTon)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LoaiSanPham.TenLoai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LoaiSanPham.TenLoai)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Xóa" class="btn btn-warning" /> |
            @Html.ActionLink("Quay lại", "Index")
        </div>
    End Using
</div>
