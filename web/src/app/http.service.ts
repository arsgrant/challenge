import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }

  post(url: string, body: any) {
    return this.http.post<any>(url, JSON.stringify(body));
  } 

  get(url: string) {
    return this.http.get<any>(url);
  }

}
