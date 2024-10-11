import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

@Component({
  selector: 'app-thanh-vien',
  templateUrl: './thanh-vien.component.html',
  styleUrls: ['./thanh-vien.component.css']
})
export class ThanhVienComponent implements OnInit {

  @ViewChild('ThanhVienSort') ThanhVienSort: MatSort;
  @ViewChild('ThanhVienPaginator') ThanhVienPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
  ) { }

  ngOnInit(): void {  
    this.ThanhVienSearch();  
  }

  ThanhVienSearch() {
    this.ThanhVienService.SearchAll(this.ThanhVienSort, this.ThanhVienPaginator);
  }
  ThanhVienSave(element: ThanhVien) {
    this.ThanhVienService.FormData = element;
    this.NotificationService.warn(this.ThanhVienService.ComponentSaveAll(this.ThanhVienSort, this.ThanhVienPaginator));
  }
  ThanhVienDelete(element: ThanhVien) {
    this.ThanhVienService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ThanhVienService.ComponentDeleteAll(this.ThanhVienSort, this.ThanhVienPaginator));
  }  
}