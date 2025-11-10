import { Component, Input} from '@angular/core';

@Component({
  selector: 'app-room-card',
  imports: [],
  templateUrl: './room-card.html',
  styleUrl: './room-card.scss',
})
export class RoomCard {

  @Input() roomNumber!: string;
  @Input() status!: number
  @Input() pricePerNight!: number;

}
