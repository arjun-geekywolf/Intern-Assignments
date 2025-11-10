import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from "@angular/router";
import { CommonModule } from '@angular/common';
import { HotelService } from '../../../services/hotel';


@Component({
  selector: 'app-hotel-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './hotel-list.html',
  styleUrls: ['./hotel-list.scss']
})
export class HotelList {

  hotels: any[] = [];

  constructor(
    private router: Router,
    private hotelService: HotelService
  ) {}

  ngOnInit() {
    this.hotelService.getHotels().subscribe((data) => {
      this.hotels = data;
    });
  }

  navigate(route: string) {
    this.router.navigate([route]);
  }
}
