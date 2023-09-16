import { Component, OnInit, ViewChild, inject } from '@angular/core';
import { GoogleMap, MapInfoWindow, MapMarker } from '@angular/google-maps';

import { WeatherStationDto } from 'src/app/1-models/WeatherStationDto';
import { WeatherStationRepoService } from 'src/app/2-services/weather-station-repo.service';

@Component({
  selector: 'app-home-page',
  templateUrl: 'home-page.component.html',
})
export class HomePageComponent implements OnInit {
  private stationRepo = inject(WeatherStationRepoService);

  @ViewChild(GoogleMap, { static: false }) map: GoogleMap;
  @ViewChild(MapInfoWindow, { static: false }) infoWindow: MapInfoWindow;

  center: google.maps.LatLngLiteral = {
    lat: -24.527135,
    lng: 133.941381,
  };
  zoom = 4.2;

  chosenState: string = '';
  weatherStations: WeatherStationDto[] = [];
  selectedStation: WeatherStationDto | null;

  get displayedStations(): WeatherStationDto[] {
    if (this.chosenState === '') return this.weatherStations;

    return this.weatherStations.filter((station) => station.state.toLowerCase() === this.chosenState.toLowerCase());
  }

  async ngOnInit() {
    this.weatherStations = await this.stationRepo.getAllAsync();
  }

  onFilterChange = () => {
    this.infoWindow.close();
    this.selectedStation = null;
    this.center = {
      lat: -24.527135,
      lng: 133.941381,
    };
    this.zoom = 4.2;
  };

  bindMapMarker = (marker: MapMarker, station: WeatherStationDto) => {
    if (station.mapMarker) return;

    station.mapMarker = marker;
  };

  openInfo = (station: WeatherStationDto) => {
    this.selectedStation = station;

    this.center = station.markerPosition;
    this.zoom = 6;
    this.infoWindow.open(station.mapMarker);
  };
}
