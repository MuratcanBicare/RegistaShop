﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RegistaShop.Catalog.Dtos.FeatureSliderDtos;
using RegistaShop.Catalog.Entities;
using RegistaShop.Catalog.Settings;

namespace RegistaShop.Catalog.Services.FeatureSliderServices
{
	public class FeatureSliderService : IFeatureSliderService
	{

		private readonly IMongoCollection<FeatureSlider> _featureSliderCollection;
		private readonly IMapper _mapper;

		public FeatureSliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_featureSliderCollection = database.GetCollection<FeatureSlider>(_databaseSettings.FeatureSliderCollectionName);
			_mapper = mapper;
		}

		public async Task CreateFeatureSliderAsync(CreateFeatureSliderDto createFeatureSliderDto)
		{
			var value = _mapper.Map<FeatureSlider>(createFeatureSliderDto);
			await _featureSliderCollection.InsertOneAsync(value);
		}

		public async Task DeleteFeatureSliderAsync(string id)
		{
			await _featureSliderCollection.DeleteOneAsync(x => x.FeatureSliderId == id);
		}

		public Task FeatureSliderChangeStatusToFalse(string id)
		{
			throw new NotImplementedException();
		}

		public Task FeatureSliderChangeStatusToTrue(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync()
		{
			var values = await _featureSliderCollection.Find(x => true).ToListAsync();
			return _mapper.Map<List<ResultFeatureSliderDto>>(values);
		}

		public async Task<GetByIdFeatureSliderDto> GetByIdFeatureSliderByIdAsync(string id)
		{
			var values = await _featureSliderCollection.Find<FeatureSlider>(x => x.FeatureSliderId == id).FirstOrDefaultAsync();
			return _mapper.Map<GetByIdFeatureSliderDto>(values);
		}

		public async Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto updateFeatureSliderDto)
		{
			var values = _mapper.Map<FeatureSlider>(updateFeatureSliderDto);
			await _featureSliderCollection.FindOneAndReplaceAsync(x => x.FeatureSliderId == updateFeatureSliderDto.FeatureSliderId, values);
		}

	}
}