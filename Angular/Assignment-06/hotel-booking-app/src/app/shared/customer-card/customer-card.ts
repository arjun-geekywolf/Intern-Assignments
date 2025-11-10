import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-customer-card',
  imports: [],
  standalone: true,
  templateUrl: './customer-card.html',
  styleUrl: './customer-card.scss',
})
export class CustomerCard {
  @Input() id!: number;
  @Input() fullName!: string
  @Input() email!: string;
  @Input() phoneNumber!: string;
  @Input() idproofNumber!: string;


@Output() navigateUrl = new EventEmitter<string>();


goto(url: string) {
  this.navigateUrl.emit(url);
}
}
