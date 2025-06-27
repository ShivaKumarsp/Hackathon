import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'search',
  standalone: false
})
export class SearchPipe implements PipeTransform {
  transform(items: any[], searchText: string, key: string): any[] {
    if (!items || !searchText) return items;
    searchText = searchText.toLowerCase();
    return items.filter(item => item[key]?.toLowerCase().includes(searchText));
  }
}


