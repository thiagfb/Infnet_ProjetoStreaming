import { DeatailBandaComponent } from './detail-banda/deatail-banda/deatail-banda.component';
import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: "detail/:id",
    component: DeatailBandaComponent
  }
];
