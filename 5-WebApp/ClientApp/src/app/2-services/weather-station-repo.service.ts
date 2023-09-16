import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from 'src/environments/environment';
import { WeatherStationDto } from '../1-models/WeatherStationDto';
import { lastValueFrom, map } from 'rxjs';
import { plainToInstance } from 'class-transformer';

@Injectable({ providedIn: 'root' })
export class WeatherStationRepoService {
  private http = inject(HttpClient);

  private readonly _baseUrl: string = `${environment.baseUrl}/WeatherStations`;

  getAllAsync(): Promise<WeatherStationDto[]> {
    return lastValueFrom(
      this.http
        .get<WeatherStationDto[]>(this._baseUrl)
        .pipe(map((response) => plainToInstance(WeatherStationDto, response)))
    );
  }
}
