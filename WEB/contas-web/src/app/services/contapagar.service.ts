import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Contapagar } from '../models/contapagar.model';

const baseUrl = 'http://localhost:52817/api/contapagar';

@Injectable({
  providedIn: 'root'
})
export class ContapagarService {

  constructor(private http: HttpClient) { }

  list(): Observable<Contapagar[]> {
    return this.http.get<Contapagar[]>(baseUrl);
  }

  find(id: number): Observable<Contapagar> {
    return this.http.get<Contapagar>(`${baseUrl}/${id}`);
  }

  add(data: Contapagar): Observable<any> {
    return this.http.post(baseUrl, data);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(`${baseUrl}/${id}`);
  }
}
