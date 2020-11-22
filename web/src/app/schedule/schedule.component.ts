import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { HttpService } from '../http.service';
import { UrlService } from '../url.service';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {

  id: any;
  inscRouter: Subscription;

  loading: boolean;
  list: any[];

  pageCount: number;
  page: number = 1 ;

  pageTimeCount: number;
  pageTime: number = 1 ;

  constructor(
    private route: ActivatedRoute,
    private httpService: HttpService,
    private urlService: UrlService,
    private router: Router) { }

    ngOnInit() {
      this.inscRouter = this.route.params.subscribe(
        (params: any) => {
          this.id = params['id'];
          if (this.id!=null) {
            this.httpService.get(this.urlService.getURL().ProfessionalScheduleList + '/' + this.id)
            .subscribe(
                (res) => {
                  this.list = res;
                  this.pageCount = this.list.length / 4;
                },
                (error) => {
                  alert(error.message);
                }
            );
          }
        });
    }
    
    priorPage() {
      if (this.page > 1) {
        this.page--;
      }
    }

    nextPage() {
      if (this.page < this.pageCount) {
        this.page++;
      }
    }

    priorPageTime() {
      if (this.pageTime > 1) {
        this.pageTime--;
      }
    }

    nextPageTime() {
      if (this.pageTime < this.pageCount) {
        this.pageTime++;
      }
    }    

}
