import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UrlService {
  
  private url_base = environment.url_base;
  private app_base = environment.app_base;

  URL = {

    // Professional
    ProfessionalList: this.url_base + this.app_base + 'professional/list',
    ProfessionalScheduleList: this.url_base + this.app_base + 'professional/list-schedule'
  };

  constructor() { }

  getURL() {
    return this.URL;
  }

}
