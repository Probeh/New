import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'transform' })
export class TransformPipe implements PipeTransform {

  transform(value: string, args?: number): any {
    var result = '';
    for (let index = 0; index < value.length; index++) {
      if (!args || args > index) {
        result += index == 0
          ? value[0].toUpperCase()
          : value[index] == value[index].toUpperCase()
            ? ` ${value[index]}`
            : value[index];
      }
      else break;
    }
    return result;
  }

}
