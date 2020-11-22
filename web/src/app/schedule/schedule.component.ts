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

  timeChecked : any = null;

  showMessage: Boolean = false;
  message: "";
  classMessage: any;

  interval : any = null;

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
                  this.pageCount = Math.trunc(this.list.length / 5);
                  this.pageTimeCount = Math.trunc(this.list[0].times.length / 5);
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
      if (this.pageTime < this.pageTimeCount) {
        this.pageTime++;
      }
    }    

    choiceTime(time) {
      if (time===this.timeChecked) {
        this.timeChecked.checked = false;
        this.timeChecked = null;
      } else {
        if (this.timeChecked) {
          this.timeChecked.checked = false;
        }
        this.timeChecked = time;
        time.checked = true;
      }
    }

    private sendeDangerMessage(msg) {
      this.classMessage = "alert alert-danger";
      this.message = msg;
      this.interval = setInterval(() => {
        this.message = "";
        clearInterval(this.interval);
      }, 3000);
    }

    private sendeSuccessMessage(msg) {
      this.classMessage = "alert alert-success";
      this.message = msg;
      this.interval = setInterval(() => {
        this.message = "";
        clearInterval(this.interval);
      }, 3000);
    }

    confirm() {
      if (this.timeChecked==null) {
        this.sendeDangerMessage("Choice a time!");
      } else {
        this.sendeSuccessMessage("Scheduled time!");
      }
    }

}
