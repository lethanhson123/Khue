import { Component } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Router, NavigationEnd } from '@angular/router';
import { DownloadService } from 'src/app/shared/Download.service';
import { NotificationService } from 'src/app/shared/Notification.service';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  PageTitle = environment.PageTitle;
  PageDescription = environment.PageDescription;
  PageTitleShort = environment.PageTitleShort;
  domainName = environment.DomainDestination;
  domainURL = environment.DomainURL;
  queryString: string = environment.InitializationString;
  queryStringSub: string = environment.InitializationString;
  Token: string = environment.InitializationString;
  constructor(
    public router: Router,
    public DownloadService: DownloadService,
    public NotificationService: NotificationService,


  ) {

  }
  ngOnInit(): void {

  }
  ngAfterViewInit() {
  }


}