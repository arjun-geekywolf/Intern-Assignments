import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({ providedIn: 'root' })
export class HotelService {
  private dataUrl = 'assets/data/hotel.json';

  constructor(private http: HttpClient) {}

  getHotels(): Observable<any[]> {
    return this.http.get<any[]>(this.dataUrl);
  }

  getRooms(hotelId: number): Observable<any[]> {
    const url = `assets/data/rooms.json`;
    return this.http.get<any[]>(url);
  }
}
