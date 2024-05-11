import { routes } from './../app.routes';
import { Component, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { Banda } from '../model/banda';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BandaService } from '../services/banda/banda.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [MatCardModule, MatButtonModule, HttpClientModule, CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent implements OnInit {

  bandas = null;

  constructor(private bandaService: BandaService) {
  }
  ngOnInit(): void {
    this.bandaService.getBanda().subscribe(response => {
      console.log(response);
      this.bandas = response as any;
    });
  }

  public goToDetail(item:Banda){
    this.router.navigate(["detail", item.id]);

  }

}
