import { Component } from '@angular/core';
import { RouterOutlet, RouterLinkWithHref, RouterLink, RouterLinkActive } from "@angular/router";

@Component({
  selector: 'app-hotel-details',
  imports: [RouterOutlet, RouterLinkWithHref,RouterLinkActive],
  templateUrl: './hotel-details.html',
  styleUrl: './hotel-details.scss',
})
export class HotelDetails {

}
