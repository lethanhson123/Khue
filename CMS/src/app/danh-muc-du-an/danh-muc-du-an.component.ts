import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucDuAn } from 'src/app/shared/DanhMucDuAn.model';
import { DanhMucDuAnService } from 'src/app/shared/DanhMucDuAn.service';

@Component({
  selector: 'app-danh-muc-du-an',
  templateUrl: './danh-muc-du-an.component.html',
  styleUrls: ['./danh-muc-du-an.component.css']
})
export class DanhMucDuAnComponent implements OnInit {

  @ViewChild('DanhMucDuAnSort') DanhMucDuAnSort: MatSort;
  @ViewChild('DanhMucDuAnPaginator') DanhMucDuAnPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDuAnService: DanhMucDuAnService,
  ) { }

  ngOnInit(): void {  
    this.DanhMucDuAnSearch();  
  }

  DanhMucDuAnSearch() {
    this.DanhMucDuAnService.SearchAll(this.DanhMucDuAnSort, this.DanhMucDuAnPaginator);
  }
  DanhMucDuAnSave(element: DanhMucDuAn) {
    this.DanhMucDuAnService.FormData = element;
    this.NotificationService.warn(this.DanhMucDuAnService.ComponentSaveAll(this.DanhMucDuAnSort, this.DanhMucDuAnPaginator));
  }
  DanhMucDuAnDelete(element: DanhMucDuAn) {
    this.DanhMucDuAnService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucDuAnService.ComponentDeleteAll(this.DanhMucDuAnSort, this.DanhMucDuAnPaginator));
  }  
}