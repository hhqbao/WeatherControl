import { Routes } from '@angular/router';
import { HomePageComponent } from './4-pages/home-page/home-page.component';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    title: 'Weather Control - Home page',
    component: HomePageComponent,
  },
];
