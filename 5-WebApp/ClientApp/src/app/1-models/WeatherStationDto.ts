import { Type } from 'class-transformer';
import { WeatherRecordDto } from './WeatherRecordDto';
import * as moment from 'moment';
import { MapMarker } from '@angular/google-maps';

export class WeatherStationDto {
  id: number;
  name: string;
  site: string;
  porfolio: string;
  state: string;
  latitude: number;
  longitude: number;

  @Type(() => WeatherRecordDto)
  weatherRecords: WeatherRecordDto[];

  mapMarker: MapMarker;

  get markerPosition(): google.maps.LatLngLiteral {
    return { lat: this.latitude, lng: this.longitude };
  }

  get markerOptions(): any {
    return { icon: 'assets/images/Solar-72-x-72.webp' };
  }

  get infoContent(): string {
    let dataBody = '';

    this.weatherRecords.forEach((record) => {
      dataBody += `
        <tr>
          <td>${record.variableName}</td>
          <td>${record.recordedValue}</td>
          <td>${record.variableUnit}</td>
          <td>${moment(record.recordedTime).format('DD/MM/YYYY HH:mm')}</td>
        </tr>
      `;
    });

    return `
      <div class="station-marker-info">
        <div class="station-name">${this.name}</div>
        <ul class="station-details">
          <li class="detail">
            <label class="detail__label">Site:</label>
            <label class="detail__value">${this.site}</label>
          </li>
          <li class="detail">
            <label class="detail__label">State:</label>
            <label class="detail__value">${this.state}</label>
          </li>
          <li class="detail">
            <label class="detail__label">Porfolio:</label>
            <label class="detail__value">${this.porfolio}</label>
          </li>
        </ul>
        <table class="table table--1">
          <thead>
            <tr>
              <th>Variable</th>
              <th>Value</th>
              <th>Unit</th>
              <th><i class="fa-solid fa-clock"></i> Time</th>
            </tr>
          </thead>
          <tbody>
            ${dataBody}
          </tbody>
        </table>
      </div>
    `;
  }
}
