import { Model } from './model';

export class Profile<T extends Model<T>> extends Model<T> {
  public summary?: string;
  public description?: string;
}
