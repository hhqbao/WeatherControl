import { Type } from 'class-transformer';
import { WeatherRecordDto } from './WeatherRecordDto';

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
}
