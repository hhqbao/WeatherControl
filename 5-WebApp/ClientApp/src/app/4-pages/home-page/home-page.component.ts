import { Component, OnInit, inject } from '@angular/core';
import { WeatherStationDto } from 'src/app/1-models/WeatherStationDto';
import { WeatherStationRepoService } from 'src/app/2-services/weather-station-repo.service';

@Component({
  selector: 'app-home-page',
  templateUrl: 'home-page.component.html',
})
export class HomePageComponent implements OnInit {
  private stationRepo = inject(WeatherStationRepoService);

  weatherStations: WeatherStationDto[];

  async ngOnInit() {
    this.weatherStations = await this.stationRepo.getAllAsync();

    console.log(this.weatherStations);
  }
}
