import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Allapi {

  constructor(private http:HttpClient) { }

  
  public baseUrl='http://localhost:5100/api/';

   httpGet(url:any): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl+url);
  }
   httpPost(url:any, data: any): Observable<any[]> {
    return this.http.post<any[]>(this.baseUrl+url, data);
  }

  httpPut(url:any,data: any): Observable<void> {
    return this.http.put<void>(`${this.baseUrl}/${data.id}`, data);
  }

  httpDelete(url:any,id: number): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/${id}`);
  }
}
