import { Component } from '@angular/core';
import { HotelService } from '../../../services/hotel';
import { Router } from '@angular/router';
import { RoomCard } from '../../../shared/room-card/room-card';

@Component({
  selector: 'app-rooms-list',
  imports: [RoomCard],
  templateUrl: './rooms-list.html',
  styleUrls: ['./rooms-list.scss'],
})
export class RoomsList {

  rooms: any[] = [];

  constructor(
    private router: Router,
    private hotelService: HotelService
  ) {}

  ngOnInit() {
    this.hotelService.getRooms(1).subscribe((data) => {
      this.rooms = data;
    });
  }

}
