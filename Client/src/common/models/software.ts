import { Profile } from './core/profile';
import { Company } from './company';
import { Product } from './product';
import { Service } from './service';

export class Software extends Profile<Software> {
  public companyId?: number;
  public productId?: number;
  public company?: Company;
  public product?: Product;
  public services?: Array<Service>;
}
