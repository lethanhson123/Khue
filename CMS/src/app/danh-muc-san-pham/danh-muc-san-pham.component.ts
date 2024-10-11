import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucSanPham } from 'src/app/shared/DanhMucSanPham.model';
import { DanhMucSanPhamService } from 'src/app/shared/DanhMucSanPham.service';

@Component({
  selector: 'app-danh-muc-san-pham',
  templateUrl: './danh-muc-san-pham.component.html',
  styleUrls: ['./danh-muc-san-pham.component.css']
})
export class DanhMucSanPhamComponent implements OnInit {

  @ViewChild('DanhMucSanPhamSort') DanhMucSanPhamSort: MatSort;
  @ViewChild('DanhMucSanPhamPaginator') DanhMucSanPhamPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucSanPhamService: DanhMucSanPhamService,
  ) { }

  ngOnInit(): void {  
    this.DanhMucSanPhamSearch();  
  }

  DanhMucSanPhamSearch() {
    this.DanhMucSanPhamService.SearchAll(this.DanhMucSanPhamSort, this.DanhMucSanPhamPaginator);
  }
  DanhMucSanPhamSave(element: DanhMucSanPham) {
    this.DanhMucSanPhamService.FormData = element;
    this.NotificationService.warn(this.DanhMucSanPhamService.ComponentSaveAll(this.DanhMucSanPhamSort, this.DanhMucSanPhamPaginator));
  }
  DanhMucSanPhamDelete(element: DanhMucSanPham) {
    this.DanhMucSanPhamService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucSanPhamService.ComponentDeleteAll(this.DanhMucSanPhamSort, this.DanhMucSanPhamPaginator));
  }  
}