Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CBIR

Namespace Controllers
    Public Class BangSanPhamController
        Inherits System.Web.Mvc.Controller

        Private db As New CS4PEEntities

        ' GET: BangSanPham
        Function Index() As ActionResult
            Dim bangSanPhams = db.BangSanPhams.Include(Function(b) b.LoaiSanPham)
            Return View(bangSanPhams.ToList())
        End Function

        ' GET: BangSanPham/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bangSanPham As BangSanPham = db.BangSanPhams.Find(id)
            If IsNothing(bangSanPham) Then
                Return HttpNotFound()
            End If
            Return View(bangSanPham)
        End Function

        ' GET: BangSanPham/Create
        Function Create() As ActionResult
            ViewBag.Loai_id = New SelectList(db.LoaiSanPhams, "id", "TenLoai")
            Return View()
        End Function

        ' POST: BangSanPham/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,MaSP,TenSP,Loai_id,GiaBan,GiaGoc,GiaGop,SoLuongTon")> ByVal bangSanPham As BangSanPham) As ActionResult
            If ModelState.IsValid Then
                db.BangSanPhams.Add(bangSanPham)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Loai_id = New SelectList(db.LoaiSanPhams, "id", "TenLoai", bangSanPham.Loai_id)
            Return View(bangSanPham)
        End Function

        ' GET: BangSanPham/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bangSanPham As BangSanPham = db.BangSanPhams.Find(id)
            If IsNothing(bangSanPham) Then
                Return HttpNotFound()
            End If
            ViewBag.Loai_id = New SelectList(db.LoaiSanPhams, "id", "TenLoai", bangSanPham.Loai_id)
            Return View(bangSanPham)
        End Function

        ' POST: BangSanPham/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,MaSP,TenSP,Loai_id,GiaBan,GiaGoc,GiaGop,SoLuongTon")> ByVal bangSanPham As BangSanPham) As ActionResult
            If ModelState.IsValid Then
                db.Entry(bangSanPham).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Loai_id = New SelectList(db.LoaiSanPhams, "id", "TenLoai", bangSanPham.Loai_id)
            Return View(bangSanPham)
        End Function

        ' GET: BangSanPham/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bangSanPham As BangSanPham = db.BangSanPhams.Find(id)
            If IsNothing(bangSanPham) Then
                Return HttpNotFound()
            End If
            Return View(bangSanPham)
        End Function

        ' POST: BangSanPham/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim bangSanPham As BangSanPham = db.BangSanPhams.Find(id)
            db.BangSanPhams.Remove(bangSanPham)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
