import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TenentListComponent } from './tenent-list.component';

describe('TenentListComponent', () => {
  let component: TenentListComponent;
  let fixture: ComponentFixture<TenentListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TenentListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TenentListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
