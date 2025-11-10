import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class customerService {
  
private dataUrl = "assets/data/customers.json";

  constructor(private http: HttpClient) {}

  getCustomers(): Observable<any[]> {
    return this.http.get<any[]>(this.dataUrl);
  }

  getCustomerDetails(customerId: number): Observable<any> {

  return this.http.get<any[]>(this.dataUrl).pipe(
      map((customers: any[]) => customers.find(c => c.id === customerId))
    );

  }

}
