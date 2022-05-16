import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  readonly rootURL = 'https://localhost:44368/api';

  constructor(private http: HttpClient) { }

  getCategories() : Observable<any[]> {
    return this.http.get<any>(this.rootURL + '/categories');
  }

  getCategory(id: number) : Observable<any> {
    return this.http.get<any>(this.rootURL + '/categories/' + id);
  }

  addCategory(category: any) : Observable<any> {
    return this.http.post<any>(this.rootURL + '/categories', category);
  }

  updateCategory(id: number, category: any) : Observable<any> {
    return this.http.put<any>(this.rootURL + '/categories', category);
  }

  deleteCategory(id: number) : Observable<any> {
    return this.http.delete<any>(this.rootURL + '/categories/' + id);
  }
}
