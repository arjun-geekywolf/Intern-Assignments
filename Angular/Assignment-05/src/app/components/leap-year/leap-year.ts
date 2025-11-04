import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-leap-year',
  imports: [CommonModule,FormsModule],
  templateUrl: './leap-year.html',
  styleUrl: './leap-year.scss',
})
export class LeapYear {

  year: number | null= null;
  result: string | null= null;

  checkLeapYear() {
    if (this.year === null) {
      this.result = 'Please enter a year';
      return;
    }

    const isLeap = (this.year % 4 === 0 && this.year % 100 !== 0) || (this.year % 400 === 0);
    this.result = isLeap ? 'Leap Year' : 'Not a Leap Year';
}
}