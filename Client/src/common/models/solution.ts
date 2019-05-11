import { Profile } from './core/profile';
import { Software } from './software';
import { Procedure } from './procedure';

export class Solution extends Profile<Solution> {
  public softwareId?: number;
  public software?: Software;
  public procedures?: Array<Procedure>;
}
