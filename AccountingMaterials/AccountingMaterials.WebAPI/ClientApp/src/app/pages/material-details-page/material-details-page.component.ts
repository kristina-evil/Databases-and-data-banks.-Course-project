import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {MaterialsDataService} from 'src/app/services/materials.service';

import {Material} from '../../models/material.interface';

@Component({
  selector: 'kks-details-page',
  templateUrl: './material-details-page.component.html',
  styleUrls: ['./material-details-page.component.scss'],
})
export class MaterialDetailsPageComponent implements OnInit {
  material: Material;

  constructor(
    private route: ActivatedRoute,
    private materialsService: MaterialsDataService
  ) {
  }

  ngOnInit(): void {
    this.getMaterial();
  }

  getMaterial(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.materialsService
      .getMaterialById(id)
      .subscribe((material) => (this.material = material));
  }

  update() {
    this.materialsService.updateMaterial(this.material).subscribe();
  }
}
