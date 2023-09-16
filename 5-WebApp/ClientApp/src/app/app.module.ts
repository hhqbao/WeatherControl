import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

import { routes } from './app.routes';
import { HomePageComponent } from './4-pages/home-page/home-page.component';
import { WeatherStationRepoService } from './2-services/weather-station-repo.service';
import { GoogleMapsModule } from '@angular/google-maps';

@NgModule({
  declarations: [AppComponent, HomePageComponent],
  imports: [BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }), HttpClientModule, FormsModule, RouterModule.forRoot(routes), GoogleMapsModule],
  providers: [WeatherStationRepoService],
  bootstrap: [AppComponent],
})
export class AppModule {}
