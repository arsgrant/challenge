import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpService } from '../http.service';
import { UrlService } from '../url.service';

@Component({
  selector: 'app-professional',
  templateUrl: './professional.component.html',
  styleUrls: ['./professional.component.css']
})
export class ProfessionalComponent implements OnInit {
  
  loading: boolean;
  list: any[];

  constructor(
    private httpService: HttpService,
    private urlService: UrlService,
    private router: Router) { }

  ngOnInit() {
    this.refreshList();
  }

  refreshList = function () {
    this.loading = true;
    
    this.list = [];    
    this.httpService.get(this.urlService.getURL().ProfessionalList)
    .subscribe(
        (res) => {
          this.loading = false;
          this.list = res;
        },
        (error) => {
          alert(error);
        }
    );
  }

  showModal() {
    
  }

}
