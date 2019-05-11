import { Profile } from './core/profile';
import { Software } from './software';
import { Service } from './service';
import { Product } from './product';

export class Company extends Profile<Company> {
  public software?: Array<Software>;
  public products?: Array<Product>;
  public services?: Array<Service>;
}
